using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Coracina;

/// <summary>
/// Abstract class for Coracina (genus).
/// NCBI TaxId: 108824
/// </summary>
public abstract class Coracina : Campephagidae, ICoracina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coracina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108824;

    /// <inheritdoc />
    public virtual string GenusName => "Coracina";

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
