using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Paramolgula;

/// <summary>
/// Abstract class for Paramolgula (genus).
/// NCBI TaxId: 1774214
/// </summary>
public abstract class Paramolgula : Molgulidae, IParamolgula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramolgula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1774214;

    /// <inheritdoc />
    public virtual string GenusName => "Paramolgula";

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
