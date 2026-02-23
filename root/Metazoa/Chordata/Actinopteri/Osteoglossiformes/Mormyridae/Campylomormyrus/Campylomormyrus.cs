using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Campylomormyrus;

/// <summary>
/// Abstract class for Campylomormyrus (genus).
/// NCBI TaxId: 91718
/// </summary>
public abstract class Campylomormyrus : Mormyridae, ICampylomormyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campylomormyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91718;

    /// <inheritdoc />
    public virtual string GenusName => "Campylomormyrus";

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
