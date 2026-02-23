using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Doliolina;

/// <summary>
/// Abstract class for Doliolina (genus).
/// NCBI TaxId: 2978591
/// </summary>
public abstract class Doliolina : Doliolidae, IDoliolina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doliolina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2978591;

    /// <inheritdoc />
    public virtual string GenusName => "Doliolina";

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
