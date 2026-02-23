using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Onychorhynchus;

/// <summary>
/// Abstract class for Onychorhynchus (genus).
/// NCBI TaxId: 360223
/// </summary>
public abstract class Onychorhynchus : Tyrannidae, IOnychorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Onychorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360223;

    /// <inheritdoc />
    public virtual string GenusName => "Onychorhynchus";

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
