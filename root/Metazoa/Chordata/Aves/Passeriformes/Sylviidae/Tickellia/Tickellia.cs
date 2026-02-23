using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Tickellia;

/// <summary>
/// Abstract class for Tickellia (genus).
/// NCBI TaxId: 330767
/// </summary>
public abstract class Tickellia : Sylviidae, ITickellia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tickellia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330767;

    /// <inheritdoc />
    public virtual string GenusName => "Tickellia";

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
