using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Didemnum;

/// <summary>
/// Abstract class for Didemnum (genus).
/// NCBI TaxId: 107394
/// </summary>
public abstract class Didemnum : Didemnidae, IDidemnum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Didemnum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107394;

    /// <inheritdoc />
    public virtual string GenusName => "Didemnum";

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
