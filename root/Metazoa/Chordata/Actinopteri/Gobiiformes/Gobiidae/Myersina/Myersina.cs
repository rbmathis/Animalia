using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Myersina;

/// <summary>
/// Abstract class for Myersina (genus).
/// NCBI TaxId: 376887
/// </summary>
public abstract class Myersina : Gobiidae, IMyersina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myersina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376887;

    /// <inheritdoc />
    public virtual string GenusName => "Myersina";

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
