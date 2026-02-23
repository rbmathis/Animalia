using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cathorops;

/// <summary>
/// Abstract class for Cathorops (genus).
/// NCBI TaxId: 243727
/// </summary>
public abstract class Cathorops : Ariidae, ICathorops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cathorops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 243727;

    /// <inheritdoc />
    public virtual string GenusName => "Cathorops";

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
