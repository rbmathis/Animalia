using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Gigantactis;

/// <summary>
/// Abstract class for Gigantactis (genus).
/// NCBI TaxId: 242957
/// </summary>
public abstract class Gigantactis : Gigantactinidae, IGigantactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gigantactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242957;

    /// <inheritdoc />
    public virtual string GenusName => "Gigantactis";

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
