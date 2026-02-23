using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Euscarthmus;

/// <summary>
/// Abstract class for Euscarthmus (genus).
/// NCBI TaxId: 478628
/// </summary>
public abstract class Euscarthmus : Tyrannidae, IEuscarthmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euscarthmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478628;

    /// <inheritdoc />
    public virtual string GenusName => "Euscarthmus";

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
