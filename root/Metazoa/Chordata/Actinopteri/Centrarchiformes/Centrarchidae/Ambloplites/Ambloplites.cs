using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Ambloplites;

/// <summary>
/// Abstract class for Ambloplites (genus).
/// NCBI TaxId: 109272
/// </summary>
public abstract class Ambloplites : Centrarchidae, IAmbloplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ambloplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109272;

    /// <inheritdoc />
    public virtual string GenusName => "Ambloplites";

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
