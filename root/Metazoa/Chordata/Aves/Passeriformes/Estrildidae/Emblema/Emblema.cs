using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Emblema;

/// <summary>
/// Abstract class for Emblema (genus).
/// NCBI TaxId: 247744
/// </summary>
public abstract class Emblema : Estrildidae, IEmblema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emblema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247744;

    /// <inheritdoc />
    public virtual string GenusName => "Emblema";

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
