using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Anastomus;

/// <summary>
/// Abstract class for Anastomus (genus).
/// NCBI TaxId: 1706834
/// </summary>
public abstract class Anastomus : Ciconiidae, IAnastomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anastomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1706834;

    /// <inheritdoc />
    public virtual string GenusName => "Anastomus";

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
