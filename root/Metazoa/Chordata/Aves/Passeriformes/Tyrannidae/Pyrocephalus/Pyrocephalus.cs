using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pyrocephalus;

/// <summary>
/// Abstract class for Pyrocephalus (genus).
/// NCBI TaxId: 371932
/// </summary>
public abstract class Pyrocephalus : Tyrannidae, IPyrocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 371932;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrocephalus";

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
