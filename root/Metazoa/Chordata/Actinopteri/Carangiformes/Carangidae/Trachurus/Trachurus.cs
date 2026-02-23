using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Trachurus;

/// <summary>
/// Abstract class for Trachurus (genus).
/// NCBI TaxId: 36211
/// </summary>
public abstract class Trachurus : Carangidae, ITrachurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36211;

    /// <inheritdoc />
    public virtual string GenusName => "Trachurus";

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
