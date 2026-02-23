using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Saltator;

/// <summary>
/// Abstract class for Saltator (genus).
/// NCBI TaxId: 58204
/// </summary>
public abstract class Saltator : Thraupidae, ISaltator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saltator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58204;

    /// <inheritdoc />
    public virtual string GenusName => "Saltator";

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
