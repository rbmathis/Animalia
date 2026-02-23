using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Molgula;

/// <summary>
/// Abstract class for Molgula (genus).
/// NCBI TaxId: 27574
/// </summary>
public abstract class Molgula : Molgulidae, IMolgula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Molgula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27574;

    /// <inheritdoc />
    public virtual string GenusName => "Molgula";

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
