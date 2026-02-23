using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Betta;

/// <summary>
/// Abstract class for Betta (genus).
/// NCBI TaxId: 158455
/// </summary>
public abstract class Betta : Osphronemidae, IBetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Betta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158455;

    /// <inheritdoc />
    public virtual string GenusName => "Betta";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
