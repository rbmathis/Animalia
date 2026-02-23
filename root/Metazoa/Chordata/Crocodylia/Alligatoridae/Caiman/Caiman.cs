using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Caiman;

/// <summary>
/// Abstract class for Caiman (genus).
/// NCBI TaxId: 8497
/// </summary>
public abstract class Caiman : Alligatoridae, ICaiman
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caiman";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8497;

    /// <inheritdoc />
    public virtual string GenusName => "Caiman";

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
