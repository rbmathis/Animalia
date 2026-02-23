using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botryllus;

/// <summary>
/// Abstract class for Botryllus (genus).
/// NCBI TaxId: 30300
/// </summary>
public abstract class Botryllus : Styelidae, IBotryllus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Botryllus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30300;

    /// <inheritdoc />
    public virtual string GenusName => "Botryllus";

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
