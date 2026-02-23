using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae.Rhopalaea;

/// <summary>
/// Abstract class for Rhopalaea (genus).
/// NCBI TaxId: 641103
/// </summary>
public abstract class Rhopalaea : Diazonidae, IRhopalaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhopalaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641103;

    /// <inheritdoc />
    public virtual string GenusName => "Rhopalaea";

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
