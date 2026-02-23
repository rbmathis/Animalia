using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Enchelyurus;

/// <summary>
/// Abstract class for Enchelyurus (genus).
/// NCBI TaxId: 1147082
/// </summary>
public abstract class Enchelyurus : Blenniidae, IEnchelyurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enchelyurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1147082;

    /// <inheritdoc />
    public virtual string GenusName => "Enchelyurus";

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
