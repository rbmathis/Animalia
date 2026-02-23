using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Pnoepyga;

/// <summary>
/// Abstract class for Pnoepyga (genus).
/// NCBI TaxId: 634344
/// </summary>
public abstract class Pnoepyga : Timaliidae, IPnoepyga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pnoepyga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 634344;

    /// <inheritdoc />
    public virtual string GenusName => "Pnoepyga";

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
