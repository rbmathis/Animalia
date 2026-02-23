using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Coua;

/// <summary>
/// Abstract class for Coua (genus).
/// NCBI TaxId: 121391
/// </summary>
public abstract class Coua : Cuculidae, ICoua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121391;

    /// <inheritdoc />
    public virtual string GenusName => "Coua";

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
