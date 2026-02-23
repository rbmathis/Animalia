using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Pluvialis;

/// <summary>
/// Abstract class for Pluvialis (genus).
/// NCBI TaxId: 171272
/// </summary>
public abstract class Pluvialis : Charadriidae, IPluvialis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pluvialis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171272;

    /// <inheritdoc />
    public virtual string GenusName => "Pluvialis";

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
