using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Kaupus;

/// <summary>
/// Abstract class for Kaupus (genus).
/// NCBI TaxId: 161463
/// </summary>
public abstract class Kaupus : Syngnathidae, IKaupus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaupus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161463;

    /// <inheritdoc />
    public virtual string GenusName => "Kaupus";

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
