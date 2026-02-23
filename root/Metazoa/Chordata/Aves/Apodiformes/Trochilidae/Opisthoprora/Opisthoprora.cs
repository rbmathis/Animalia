using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Opisthoprora;

/// <summary>
/// Abstract class for Opisthoprora (genus).
/// NCBI TaxId: 472896
/// </summary>
public abstract class Opisthoprora : Trochilidae, IOpisthoprora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthoprora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472896;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthoprora";

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
