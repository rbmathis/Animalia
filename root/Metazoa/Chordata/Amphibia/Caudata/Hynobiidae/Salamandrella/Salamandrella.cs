using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Salamandrella;

/// <summary>
/// Abstract class for Salamandrella (genus).
/// NCBI TaxId: 288314
/// </summary>
public abstract class Salamandrella : Hynobiidae, ISalamandrella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salamandrella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288314;

    /// <inheritdoc />
    public virtual string GenusName => "Salamandrella";

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
