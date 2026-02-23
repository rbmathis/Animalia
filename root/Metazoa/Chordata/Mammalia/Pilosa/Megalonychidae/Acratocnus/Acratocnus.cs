using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Acratocnus;

/// <summary>
/// Abstract class for Acratocnus (genus).
/// NCBI TaxId: 2546647
/// </summary>
public abstract class Acratocnus : Megalonychidae, IAcratocnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acratocnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546647;

    /// <inheritdoc />
    public virtual string GenusName => "Acratocnus";

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
