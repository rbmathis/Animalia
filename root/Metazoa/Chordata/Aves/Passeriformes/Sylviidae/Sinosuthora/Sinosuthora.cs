using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sinosuthora;

/// <summary>
/// Abstract class for Sinosuthora (genus).
/// NCBI TaxId: 2485303
/// </summary>
public abstract class Sinosuthora : Sylviidae, ISinosuthora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinosuthora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485303;

    /// <inheritdoc />
    public virtual string GenusName => "Sinosuthora";

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
