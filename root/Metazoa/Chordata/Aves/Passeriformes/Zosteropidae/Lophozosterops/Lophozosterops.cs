using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Lophozosterops;

/// <summary>
/// Abstract class for Lophozosterops (genus).
/// NCBI TaxId: 589842
/// </summary>
public abstract class Lophozosterops : Zosteropidae, ILophozosterops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophozosterops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589842;

    /// <inheritdoc />
    public virtual string GenusName => "Lophozosterops";

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
