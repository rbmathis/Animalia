using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Bostockia;

/// <summary>
/// Abstract class for Bostockia (genus).
/// NCBI TaxId: 135751
/// </summary>
public abstract class Bostockia : Percichthyidae, IBostockia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bostockia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135751;

    /// <inheritdoc />
    public virtual string GenusName => "Bostockia";

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
