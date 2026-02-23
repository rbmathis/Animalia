using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae.Grammicolepis;

/// <summary>
/// Abstract class for Grammicolepis (genus).
/// NCBI TaxId: 245698
/// </summary>
public abstract class Grammicolepis : Grammicolepididae, IGrammicolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammicolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245698;

    /// <inheritdoc />
    public virtual string GenusName => "Grammicolepis";

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
