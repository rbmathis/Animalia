using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Matobosaurus;

/// <summary>
/// Abstract class for Matobosaurus (genus).
/// NCBI TaxId: 1444761
/// </summary>
public abstract class Matobosaurus : Gerrhosauridae, IMatobosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Matobosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1444761;

    /// <inheritdoc />
    public virtual string GenusName => "Matobosaurus";

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
