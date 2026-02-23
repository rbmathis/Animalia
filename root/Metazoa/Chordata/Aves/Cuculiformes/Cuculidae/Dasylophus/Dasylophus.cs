using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Dasylophus;

/// <summary>
/// Abstract class for Dasylophus (genus).
/// NCBI TaxId: 1454920
/// </summary>
public abstract class Dasylophus : Cuculidae, IDasylophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasylophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1454920;

    /// <inheritdoc />
    public virtual string GenusName => "Dasylophus";

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
