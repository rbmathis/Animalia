using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Colossoma;

/// <summary>
/// Abstract class for Colossoma (genus).
/// NCBI TaxId: 42525
/// </summary>
public abstract class Colossoma : Serrasalmidae, IColossoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colossoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42525;

    /// <inheritdoc />
    public virtual string GenusName => "Colossoma";

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
