using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Agkistrodon;

/// <summary>
/// Abstract class for Agkistrodon (genus).
/// NCBI TaxId: 8711
/// </summary>
public abstract class Agkistrodon : Viperidae, IAgkistrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agkistrodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8711;

    /// <inheritdoc />
    public virtual string GenusName => "Agkistrodon";

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
