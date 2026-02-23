using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Serranobatrachus;

/// <summary>
/// Abstract class for Serranobatrachus (genus).
/// NCBI TaxId: 2993673
/// </summary>
public abstract class Serranobatrachus : Strabomantidae, ISerranobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serranobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2993673;

    /// <inheritdoc />
    public virtual string GenusName => "Serranobatrachus";

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
