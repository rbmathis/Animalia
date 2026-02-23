using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Phallobrycon;

/// <summary>
/// Abstract class for Phallobrycon (genus).
/// NCBI TaxId: 2608213
/// </summary>
public abstract class Phallobrycon : Stevardiidae, IPhallobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phallobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608213;

    /// <inheritdoc />
    public virtual string GenusName => "Phallobrycon";

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
