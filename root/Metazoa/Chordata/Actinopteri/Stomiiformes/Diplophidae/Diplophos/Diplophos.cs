using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae.Diplophos;

/// <summary>
/// Abstract class for Diplophos (genus).
/// NCBI TaxId: 91974
/// </summary>
public abstract class Diplophos : Diplophidae, IDiplophos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplophos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91974;

    /// <inheritdoc />
    public virtual string GenusName => "Diplophos";

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
