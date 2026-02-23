using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Doryfera;

/// <summary>
/// Abstract class for Doryfera (genus).
/// NCBI TaxId: 214664
/// </summary>
public abstract class Doryfera : Trochilidae, IDoryfera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doryfera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214664;

    /// <inheritdoc />
    public virtual string GenusName => "Doryfera";

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
