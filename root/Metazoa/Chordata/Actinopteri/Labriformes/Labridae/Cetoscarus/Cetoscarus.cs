using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cetoscarus;

/// <summary>
/// Abstract class for Cetoscarus (genus).
/// NCBI TaxId: 188106
/// </summary>
public abstract class Cetoscarus : Labridae, ICetoscarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetoscarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188106;

    /// <inheritdoc />
    public virtual string GenusName => "Cetoscarus";

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
