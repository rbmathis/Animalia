using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Rondeletiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Rondeletiidae.Rondeletia;

/// <summary>
/// Abstract class for Rondeletia (genus).
/// NCBI TaxId: 88711
/// </summary>
public abstract class Rondeletia : Rondeletiidae, IRondeletia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rondeletia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88711;

    /// <inheritdoc />
    public virtual string GenusName => "Rondeletia";

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
