using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Callisaurus;

/// <summary>
/// Abstract class for Callisaurus (genus).
/// NCBI TaxId: 43585
/// </summary>
public abstract class Callisaurus : Phrynosomatidae, ICallisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43585;

    /// <inheritdoc />
    public virtual string GenusName => "Callisaurus";

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
