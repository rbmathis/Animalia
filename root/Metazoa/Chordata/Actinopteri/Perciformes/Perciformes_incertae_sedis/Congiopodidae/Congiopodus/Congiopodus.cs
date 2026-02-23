using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Congiopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Congiopodidae.Congiopodus;

/// <summary>
/// Abstract class for Congiopodus (genus).
/// NCBI TaxId: 274723
/// </summary>
public abstract class Congiopodus : Congiopodidae, ICongiopodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congiopodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274723;

    /// <inheritdoc />
    public virtual string GenusName => "Congiopodus";

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
