using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Amblyrhynchus;

/// <summary>
/// Abstract class for Amblyrhynchus (genus).
/// NCBI TaxId: 51207
/// </summary>
public abstract class Amblyrhynchus : Iguanidae, IAmblyrhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyrhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51207;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyrhynchus";

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
