using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Edolisoma;

/// <summary>
/// Abstract class for Edolisoma (genus).
/// NCBI TaxId: 2071345
/// </summary>
public abstract class Edolisoma : Campephagidae, IEdolisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Edolisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2071345;

    /// <inheritdoc />
    public virtual string GenusName => "Edolisoma";

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
