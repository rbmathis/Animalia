using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Ctenops;

/// <summary>
/// Abstract class for Ctenops (genus).
/// NCBI TaxId: 313183
/// </summary>
public abstract class Ctenops : Osphronemidae, ICtenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 313183;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenops";

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
