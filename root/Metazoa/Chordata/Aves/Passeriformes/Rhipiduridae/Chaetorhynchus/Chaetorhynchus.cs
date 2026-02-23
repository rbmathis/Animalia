using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Chaetorhynchus;

/// <summary>
/// Abstract class for Chaetorhynchus (genus).
/// NCBI TaxId: 254445
/// </summary>
public abstract class Chaetorhynchus : Rhipiduridae, IChaetorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254445;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetorhynchus";

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
