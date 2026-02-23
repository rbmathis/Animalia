using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Doliolum;

/// <summary>
/// Abstract class for Doliolum (genus).
/// NCBI TaxId: 76840
/// </summary>
public abstract class Doliolum : Doliolidae, IDoliolum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doliolum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76840;

    /// <inheritdoc />
    public virtual string GenusName => "Doliolum";

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
