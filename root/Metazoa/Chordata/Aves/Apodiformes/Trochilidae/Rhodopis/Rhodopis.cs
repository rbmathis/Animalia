using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Rhodopis;

/// <summary>
/// Abstract class for Rhodopis (genus).
/// NCBI TaxId: 472918
/// </summary>
public abstract class Rhodopis : Trochilidae, IRhodopis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodopis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472918;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodopis";

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
