using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Lichenostomus;

/// <summary>
/// Abstract class for Lichenostomus (genus).
/// NCBI TaxId: 43158
/// </summary>
public abstract class Lichenostomus : Meliphagidae, ILichenostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lichenostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43158;

    /// <inheritdoc />
    public virtual string GenusName => "Lichenostomus";

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
