using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Coccycua;

/// <summary>
/// Abstract class for Coccycua (genus).
/// NCBI TaxId: 1118525
/// </summary>
public abstract class Coccycua : Cuculidae, ICoccycua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coccycua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118525;

    /// <inheritdoc />
    public virtual string GenusName => "Coccycua";

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
