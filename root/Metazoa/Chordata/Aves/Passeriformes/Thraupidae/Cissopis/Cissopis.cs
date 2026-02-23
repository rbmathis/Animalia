using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cissopis;

/// <summary>
/// Abstract class for Cissopis (genus).
/// NCBI TaxId: 62176
/// </summary>
public abstract class Cissopis : Thraupidae, ICissopis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cissopis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62176;

    /// <inheritdoc />
    public virtual string GenusName => "Cissopis";

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
