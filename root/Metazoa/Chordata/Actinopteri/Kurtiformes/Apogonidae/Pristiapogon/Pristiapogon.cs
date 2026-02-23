using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pristiapogon;

/// <summary>
/// Abstract class for Pristiapogon (genus).
/// NCBI TaxId: 638292
/// </summary>
public abstract class Pristiapogon : Apogonidae, IPristiapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristiapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638292;

    /// <inheritdoc />
    public virtual string GenusName => "Pristiapogon";

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
