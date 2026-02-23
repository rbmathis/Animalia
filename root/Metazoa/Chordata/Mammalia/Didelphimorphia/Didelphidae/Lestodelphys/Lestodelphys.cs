using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Lestodelphys;

/// <summary>
/// Abstract class for Lestodelphys (genus).
/// NCBI TaxId: 126291
/// </summary>
public abstract class Lestodelphys : Didelphidae, ILestodelphys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lestodelphys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126291;

    /// <inheritdoc />
    public virtual string GenusName => "Lestodelphys";

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
