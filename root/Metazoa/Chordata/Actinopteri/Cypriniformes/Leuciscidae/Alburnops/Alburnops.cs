using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Alburnops;

/// <summary>
/// Abstract class for Alburnops (genus).
/// NCBI TaxId: 3363377
/// </summary>
public abstract class Alburnops : Leuciscidae, IAlburnops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alburnops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363377;

    /// <inheritdoc />
    public virtual string GenusName => "Alburnops";

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
