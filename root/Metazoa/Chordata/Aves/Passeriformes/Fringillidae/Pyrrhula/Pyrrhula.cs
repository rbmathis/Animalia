using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Pyrrhula;

/// <summary>
/// Abstract class for Pyrrhula (genus).
/// NCBI TaxId: 37606
/// </summary>
public abstract class Pyrrhula : Fringillidae, IPyrrhula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37606;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhula";

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
