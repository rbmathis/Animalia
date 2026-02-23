using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Culeolus;

/// <summary>
/// Abstract class for Culeolus (genus).
/// NCBI TaxId: 2060133
/// </summary>
public abstract class Culeolus : Pyuridae, ICuleolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Culeolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2060133;

    /// <inheritdoc />
    public virtual string GenusName => "Culeolus";

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
