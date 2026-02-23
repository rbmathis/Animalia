using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Buenia;

/// <summary>
/// Abstract class for Buenia (genus).
/// NCBI TaxId: 441900
/// </summary>
public abstract class Buenia : Gobiidae, IBuenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 441900;

    /// <inheritdoc />
    public virtual string GenusName => "Buenia";

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
