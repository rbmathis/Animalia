using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Amyda;

/// <summary>
/// Abstract class for Amyda (genus).
/// NCBI TaxId: 161654
/// </summary>
public abstract class Amyda : Trionychidae, IAmyda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amyda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161654;

    /// <inheritdoc />
    public virtual string GenusName => "Amyda";

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
