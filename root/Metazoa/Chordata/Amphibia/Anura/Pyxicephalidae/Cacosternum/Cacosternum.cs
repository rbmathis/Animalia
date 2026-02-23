using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Cacosternum;

/// <summary>
/// Abstract class for Cacosternum (genus).
/// NCBI TaxId: 111063
/// </summary>
public abstract class Cacosternum : Pyxicephalidae, ICacosternum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cacosternum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111063;

    /// <inheritdoc />
    public virtual string GenusName => "Cacosternum";

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
